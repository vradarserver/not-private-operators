using System;
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

        private Dictionary<string, int> _AircraftListItemIndexes = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

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
            BaseStationSqbFileName =    state.BaseStationSqbFullPath;
            Filter =                    state.Filter;
            StartsWithFilter =          state.StartsWithFilter;
            ContainsFilter =            state.ContainsFilter;
            EndsWithFilter =            state.EndsWithFilter;
            ShowCategoryNone =          state.ShowCategoryNone;
            ShowCategoryNotPrivate =    state.ShowCategoryNotPrivate;
            ShowCategoryPrivate =       state.ShowCategoryPrivate;
        }

        private void SaveState()
        {
            PersistentStateManager.ChangeState(state => {
                state.BaseStationSqbFullPath =  BaseStationSqbFileName;
                state.Filter =                  Filter;
                state.StartsWithFilter =        StartsWithFilter;
                state.ContainsFilter =          ContainsFilter;
                state.EndsWithFilter =          EndsWithFilter;
                state.ShowCategoryNone =        ShowCategoryNone;
                state.ShowCategoryNotPrivate =  ShowCategoryNotPrivate;
                state.ShowCategoryPrivate =     ShowCategoryPrivate;
            });
        }

        private void LoadPrivateAircraft()
        {
            using(new WaitCursor()) {
                _AllCandidateAircraft.Clear();
                _AllCandidateAircraft.AddRange(
                    BaseStationDatabase
                        .LoadMaybePrivateAircraft(BaseStationSqbFileName)
                        .Where(r => !MilitaryIcaoRanges.IsMilitary(r.ModeS))
                        .OrderBy(r => r.RegisteredOwners.ToLower())
                );
                BuildAircraftListItems();
            }
        }

        private void BuildAircraftListItems()
        {
            using(new WaitCursor()) {
                var scrollToIdx = AircraftListView.TopItem?.Index ?? -1;

                _AircraftListItems.Clear();
                _AircraftListItemIndexes.Clear();

                AircraftListItem lastItem = null;
                foreach(var aircraft in _AllCandidateAircraft) {
                    if(PassesFilter(aircraft.RegisteredOwners, out var isNotPrivateOperator)) {
                        if(!String.Equals(aircraft.RegisteredOwners, lastItem?.OperatorName, StringComparison.OrdinalIgnoreCase)) {
                            lastItem = new AircraftListItem() {
                                OperatorName =          aircraft.RegisteredOwners,
                                IsNotPrivateOperator =  isNotPrivateOperator,
                                CountAircraft =         0,
                            };
                            _AircraftListItemIndexes.Add(lastItem.OperatorName, _AircraftListItems.Count);
                            _AircraftListItems.Add(lastItem);
                        }
                        ++lastItem.CountAircraft;
                    }
                }

                AircraftListView.BeginUpdate();
                try {
                    AircraftListView.VirtualListSize = _AircraftListItems.Count;
                    scrollToIdx = Math.Min(scrollToIdx, _AircraftListItems.Count - 1);
                    if(scrollToIdx != -1) {
                        var item = AircraftListView.FindItemWithText(_AircraftListItems[scrollToIdx].OperatorName);
                        if(item != null) {
                            AircraftListView.TopItem = item;
                        }
                    }
                } finally {
                    AircraftListView.EndUpdate();
                }
                ListViewCountLabel.Text = $"{AircraftListView.VirtualListSize:N0} item{(AircraftListView.VirtualListSize == 1 ? "" : "s")}";
            }
        }

        private bool PassesFilter(string operatorName, out bool? isNotPrivateOperator)
        {
            isNotPrivateOperator = null;

            // The categorisation can be more expensive than the filter because it involves regexes. Do the filter first.
            var result = String.IsNullOrEmpty(Filter)
                            || (StartsWithFilter && operatorName.StartsWith(Filter, StringComparison.OrdinalIgnoreCase))
                            || (EndsWithFilter && operatorName.EndsWith(Filter, StringComparison.OrdinalIgnoreCase))
                            || (ContainsFilter && operatorName.IndexOf(Filter, StringComparison.OrdinalIgnoreCase) != -1);

            if(result) {
                isNotPrivateOperator = NameAndExpressionFiles.IsNotPrivateOperator(operatorName);
                result = (isNotPrivateOperator == null && ShowCategoryNone)
                      || (isNotPrivateOperator != null && isNotPrivateOperator.Value && ShowCategoryNotPrivate)
                      || (isNotPrivateOperator != null && !isNotPrivateOperator.Value && ShowCategoryPrivate);
            }

            return result;
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

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if(!DesignMode) {
                SaveState();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if(!DesignMode) {
                NameAndExpressionFiles.Load();
                LoadState();

                NotPrivateNamesContent.StringsFile =                NameAndExpressionFiles.NotPrivateNames;
                NotPrivateRegularExpressionsContent.StringsFile =   NameAndExpressionFiles.NotPrivateRegularExpressions;
                PrivateNamesContent.StringsFile =                   NameAndExpressionFiles.PrivateNames;
            }
        }

        private void LoadPrivateAircraftButton_Click(object sender, EventArgs e)
        {
            LoadPrivateAircraft();
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

        private void AircraftListView_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            if(e.IsTextSearch) {
                if(_AircraftListItemIndexes.TryGetValue(e.Text, out var index)) {
                    e.Index = index;
                }
            }
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e) => BuildAircraftListItems();

        private void ShowCategory_CheckedChanged(object sender, EventArgs e) => BuildAircraftListItems();

        private void AddToNotPrivateNamesMenuItem_Click(object sender, EventArgs e) => AddSelectedToNotPrivateNames();

        private void RemoveFromNotPrivateNamesMenuItem_Click(object sender, EventArgs e) => RemoveSelectedFromNotPrivateNames();

        private void AddToPrivateNamesMenuItem_Click(object sender, EventArgs e) => AddSelectedToPrivateNames();

        private void RemoveFromPrivateNamesMenuItem_Click(object sender, EventArgs e) => RemoveSelectedFromPrivateNames();

        private void SaveButton_Click(object sender, EventArgs e) => NameAndExpressionFiles.Save();

        private void FileContentControl_AppliedEdit(object sender, EventArgs e) => BuildAircraftListItems();

        private IButtonControl _DefaultButtonOnEnteringFilterTextBox;

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {
            if(!DesignMode && _DefaultButtonOnEnteringFilterTextBox == null) {
                _DefaultButtonOnEnteringFilterTextBox = AcceptButton;
                AcceptButton = ApplyFilterButton;
            }
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if(!DesignMode && _DefaultButtonOnEnteringFilterTextBox != null) {
                AcceptButton = _DefaultButtonOnEnteringFilterTextBox;
                _DefaultButtonOnEnteringFilterTextBox = null;
            }
        }
    }
}
