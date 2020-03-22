﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class EditorForm : Form
    {
        class AircraftListItem
        {
            public string OperatorName { get; set; }

            public int CountAircraft { get; set; }

            public bool? IsNotPrivateOperator { get; set; }
        }

        private List<BaseStationAircraft> _AllCandidateAircraft = new List<BaseStationAircraft>();

        private List<AircraftListItem> _AircraftListItems = new List<AircraftListItem>();

        public string BaseStationSqbFileName
        {
            get => BaseStationSqbFileNameTextBox.Text.Trim();
            set => BaseStationSqbFileNameTextBox.Text = value;
        }

        public string Filter
        {
            get => FilterTextBox.Text;
            set => FilterTextBox.Text = value;
        }

        public bool StartsWithFilter
        {
            get => StartsWithRadio.Checked;
            set => StartsWithRadio.Checked = value;
        }

        public bool ContainsFilter
        {
            get => ContainsRadio.Checked;
            set => ContainsRadio.Checked = value;
        }

        public bool EndsWithFilter
        {
            get => EndsWithRadio.Checked;
            set => EndsWithRadio.Checked = value;
        }

        public bool ShowCategoryNone
        {
            get => CategoryNoneCheckBox.Checked;
            set => CategoryNoneCheckBox.Checked = value;
        }

        public bool ShowCategoryPrivate
        {
            get => CategoryPrivateCheckBox.Checked;
            set => CategoryPrivateCheckBox.Checked = value;
        }

        public bool ShowCategoryNotPrivate
        {
            get => CategoryNotPrivateCheckBox.Checked;
            set => CategoryNotPrivateCheckBox.Checked = value;
        }

        public string[] SelectedOperatorNames => AircraftListView
            .SelectedIndices
            .OfType<int>()
            .Select(r => r < _AircraftListItems.Count ? _AircraftListItems[r].OperatorName : null)
            .Where(r => r != null)
            .ToArray();

        public EditorForm()
        {
            InitializeComponent();
        }

        private void LoadState()
        {
            var state = PersistentStateManager.Load();
            BaseStationSqbFileName = state.BaseStationSqbFullPath;
        }

        private void SaveState()
        {
            PersistentStateManager.ChangeState(state => {
                state.BaseStationSqbFullPath = BaseStationSqbFileName;
            });
        }

        private void LoadPrivateAircraft()
        {
            using(new WaitCursor()) {
                _AllCandidateAircraft.Clear();
                _AllCandidateAircraft.AddRange(
                    BaseStationDatabase.LoadMaybePrivateAircraft(BaseStationSqbFileName)
                );
                BuildAircraftListItems();
            }
        }

        private void BuildAircraftListItems()
        {
            _AircraftListItems.Clear();

            _AircraftListItems.AddRange(
                _AllCandidateAircraft
                    .Select(r => new {
                        Aircraft = r,
                        IsNotPrivateOperator = NameAndExpressionFiles.IsNotPrivateOperator(r.RegisteredOwners),
                    })
                    .Where(r =>
                           !MilitaryIcaoRanges.IsMilitary(r.Aircraft.ModeS)
                        && PassesFilter(r.Aircraft.RegisteredOwners, r.IsNotPrivateOperator)
                    )
                    .GroupBy(r => r.Aircraft.RegisteredOwners.ToLower(), r => r)
                    .OrderBy(r => r.Key)
                    .Select(r => {
                        var first = r.First();
                        return new AircraftListItem() {
                            OperatorName =          first.Aircraft.RegisteredOwners,
                            CountAircraft =         r.Count(),
                            IsNotPrivateOperator =  first.IsNotPrivateOperator
                        };
                    })
            );

            AircraftListView.BeginUpdate();
            try {
                AircraftListView.VirtualListSize = _AircraftListItems.Count;
            } finally {
                AircraftListView.EndUpdate();
            }
            ListViewCountLabel.Text = $"{AircraftListView.VirtualListSize:N0} item{(AircraftListView.VirtualListSize == 1 ? "" : "s")}";
        }

        private bool PassesFilter(string ownerName, bool? isNotPrivateOwner)
        {
            var canShow =
                   (isNotPrivateOwner == null && ShowCategoryNone)
                || (isNotPrivateOwner != null && isNotPrivateOwner.Value && ShowCategoryNotPrivate)
                || (isNotPrivateOwner != null && !isNotPrivateOwner.Value && ShowCategoryPrivate);

            return canShow
                && (
                       String.IsNullOrEmpty(Filter)
                    || (StartsWithFilter && ownerName.StartsWith(Filter, StringComparison.OrdinalIgnoreCase))
                    || (EndsWithFilter && ownerName.EndsWith(Filter, StringComparison.OrdinalIgnoreCase))
                    || (ContainsFilter && ownerName.IndexOf(Filter, StringComparison.OrdinalIgnoreCase) != -1)
                   );
        }

        private void AddSelectedToNotPrivateNames()
        {
            NameAndExpressionFiles.AddToNotPrivateNames(SelectedOperatorNames);
            BuildAircraftListItems();
        }

        private void RemoveSelectedFromNotPrivateNames()
        {
            NameAndExpressionFiles.RemoveFromNotPrivateNames(SelectedOperatorNames);
            BuildAircraftListItems();
        }

        private void AddSelectedToPrivateNames()
        {
            NameAndExpressionFiles.AddToPrivateNames(SelectedOperatorNames);
            BuildAircraftListItems();
        }

        private void RemoveSelectedFromPrivateNames()
        {
            NameAndExpressionFiles.RemoveFromPrivateNames(SelectedOperatorNames);
            BuildAircraftListItems();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if(!DesignMode) {
                NameAndExpressionFiles.Load();
                LoadState();
            }
        }

        private void LoadPrivateAircraftButton_Click(object sender, EventArgs e)
        {
            LoadPrivateAircraft();
            SaveState();
        }

        private void AircraftListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if(e.ItemIndex < _AircraftListItems.Count) {
                var aircraftListItem = _AircraftListItems[e.ItemIndex];
                e.Item = new ListViewItem(new string[] {
                    aircraftListItem.OperatorName,
                    aircraftListItem.IsNotPrivateOperator == null
                        ? "None"
                        : aircraftListItem.IsNotPrivateOperator.Value
                            ? "Not Private"
                            : "Private",
                    aircraftListItem.CountAircraft.ToString("N0"),
                });
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e) => BuildAircraftListItems();

        private void FilterRadioButtons_CheckedChanged(object sender, EventArgs e) => BuildAircraftListItems();

        private void ShowCategory_CheckedChanged(object sender, EventArgs e) => BuildAircraftListItems();

        private void AddToNotPrivateNamesMenuItem_Click(object sender, EventArgs e) => AddSelectedToNotPrivateNames();

        private void RemoveFromNotPrivateNamesMenuItem_Click(object sender, EventArgs e) => RemoveSelectedFromNotPrivateNames();

        private void AddToPrivateNamesMenuItem_Click(object sender, EventArgs e) => AddSelectedToPrivateNames();

        private void RemoveFromPrivateNamesMenuItem_Click(object sender, EventArgs e) => RemoveSelectedFromPrivateNames();

        private void SaveButton_Click(object sender, EventArgs e) => NameAndExpressionFiles.Save();
    }
}
