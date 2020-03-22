using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class StringsFileContentListViewControl : UserControl
    {
        private IButtonControl _FormActiveButtonOnEntryToEditorTextBox;

        private IList<string> _Contents = new string[0];

        private StringsFile _StringsFile;
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal StringsFile StringsFile
        {
            get => _StringsFile;
            set {
                if(_StringsFile != null) {
                    _StringsFile.ContentsChanged -= StringsFile_ContentsChanged;
                }
                _StringsFile = value;
                _StringsFile.ContentsChanged += StringsFile_ContentsChanged;

                RefreshContent();
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EditEntry
        {
            get => EditEntryTextBox.Text.Trim();
            set => EditEntryTextBox.Text = value;
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<string> SelectedEntries
        {
            get => ContentsListView
                .SelectedIndices
                .OfType<int>()
                .Select(r => r < _Contents.Count ? _Contents[r] : null)
                .Where(r => r != null)
                .ToArray();

            set {
                ContentsListView.SelectedIndices.Clear();
                if(value.Count > 0) {
                    for(var i = 0;i < _Contents.Count;++i) {
                        var content = _Contents[i];
                        if(value.Any(r => String.Equals(r, content, StringComparison.OrdinalIgnoreCase))) {
                            ContentsListView.SelectedIndices.Add(i);
                        }
                    }
                }
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FirstSelectedIndex
        {
            get {
                return ContentsListView.SelectedIndices.Count == 0
                    ? -1
                    : ContentsListView
                        .SelectedIndices
                        .OfType<int>()
                        .OrderBy(r => r)
                        .First();
            }
        }

        public event EventHandler AppliedEdit;

        protected virtual void OnAppliedEdit(EventArgs args) => AppliedEdit?.Invoke(this, args);

        public StringsFileContentListViewControl()
        {
            InitializeComponent();
        }

        private void RefreshContent()
        {
            if(StringsFile != null) {
                _Contents = StringsFile.GetSortedContent();
                ContentsListView.BeginUpdate();
                try {
                    ContentsListView.VirtualListSize = _Contents.Count;
                } finally {
                    ContentsListView.EndUpdate();
                }
                CountContentLinesLabel.Text = $"{_Contents.Count:N0} line{(_Contents.Count == 1 ? "" : "s")}";
            }
        }

        private void EditFirstSelectedEntry()
        {
            var index = FirstSelectedIndex;
            EditEntry = index == -1 || index >= _Contents.Count
                ? ""
                : _Contents[index];
        }

        private void ApplyEdit()
        {
            if(StringsFile != null) {
                var trimmed = EditEntry.Trim();
                if(trimmed != "") {
                    var appliedEdit = false;
                    var index = FirstSelectedIndex;
                    if(index == -1 || index >= _Contents.Count) {
                        appliedEdit = StringsFile.AddIfNotExists(trimmed);
                    } else if(trimmed != _Contents[index]) {
                        appliedEdit = StringsFile.Replace(_Contents[index], trimmed);
                    }

                    if(appliedEdit) {
                        OnAppliedEdit(EventArgs.Empty);
                    }
                }
            }
        }

        private void RemoveSelectedEntries()
        {
            if(StringsFile != null) {
                if(StringsFile.RemoveAllIfExists(SelectedEntries)) {
                    OnAppliedEdit(EventArgs.Empty);
                }
            }
        }

        private void StringsFile_ContentsChanged(object sender, EventArgs e) => RefreshContent();

        private void ListViewContents_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if(e.ItemIndex < _Contents.Count) {
                e.Item = new ListViewItem($"\"{_Contents[e.ItemIndex]}\"") {
                    Font = EditEntryTextBox.Font,
                };
            }
        }

        private void ListViewContents_SelectedIndexChanged(object sender, EventArgs e) => EditFirstSelectedEntry();

        private void EditEntryTextBox_Enter(object sender, EventArgs e)
        {
            if(ParentForm.AcceptButton != null) {
                _FormActiveButtonOnEntryToEditorTextBox = ParentForm.AcceptButton;
                ParentForm.AcceptButton = null;
            }
        }

        private void EditEntryTextBox_Leave(object sender, EventArgs e)
        {
            if(_FormActiveButtonOnEntryToEditorTextBox != null) {
                ParentForm.AcceptButton = _FormActiveButtonOnEntryToEditorTextBox;
                _FormActiveButtonOnEntryToEditorTextBox = null;
            }
        }

        private void EditEntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                e.Handled = true;

                ApplyEdit();

                SelectedEntries = new string[0];
                EditFirstSelectedEntry();
            } else if(e.KeyCode == Keys.Space) {
                if(EditEntryTextBox.SelectionStart == 0) {
                    e.SuppressKeyPress = true;
                    e.Handled = true;
                }
            }
        }

        private void RemoveMenuItem_Click(object sender, EventArgs e) => RemoveSelectedEntries();
    }
}
