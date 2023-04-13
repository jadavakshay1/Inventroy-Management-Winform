using InventoryManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryManagementApp
{
    public partial class CategoryForm : Form
    {
        List<CategoryViewModel> model = new List<CategoryViewModel>();
        string editByCode = string.Empty;
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            lstCategory.View = View.Details;
            lstCategory.FullRowSelect = true;
            lstCategory.Columns.Add("No", 40);
            lstCategory.Columns.Add("Code", 80);
            lstCategory.Columns.Add("Name", 80);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoryCode = txtCode.Text.Trim();
            string categoryName = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(categoryCode) || string.IsNullOrWhiteSpace(categoryName))
            {
                MessageBox.Show("Please enter category Code and Name");
                return;
            }

            if ((string.IsNullOrWhiteSpace(editByCode) || editByCode != categoryCode) && model.Any(res => res.CategoryCode.ToLower().Equals(categoryCode.ToLower())))
            {
                MessageBox.Show("Category Code is already exists");
                return;
            }

            if(!string.IsNullOrWhiteSpace(editByCode) && !model.Any(res => res.CategoryCode.ToLower().Equals(editByCode.ToLower())))
            {
                MessageBox.Show("Category Code is already deleted.");
                return;
            }

            if (string.IsNullOrWhiteSpace(editByCode))
            {
                var newRecord = new CategoryViewModel
                {
                    No = model.Count() + 1,
                    CategoryCode = categoryCode,
                    CategoryName = categoryName
                };
                model.Add(newRecord);

                AddBindingList(newRecord);
            }
            else
            {
                var editModel = model.First(res => res.CategoryCode.Equals(editByCode));
                editModel.CategoryCode = categoryCode;
                editModel.CategoryName = categoryName;
                BindingListRecord();
            }
          
            btnClear.PerformClick();
        }

        void AddBindingList(CategoryViewModel newRecord)
        {
            string[] arr = new string[3];
            arr[0] = newRecord.No.ToString();
            arr[1] = newRecord.CategoryCode;
            arr[2] = newRecord.CategoryName;
            ListViewItem listViewItem = new ListViewItem(arr);
            lstCategory.Items.Add(listViewItem);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            editByCode = txtCode.Text = txtName.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editByCode = lstCategory.SelectedItems[0].SubItems[1].Text;
            if (string.IsNullOrWhiteSpace(editByCode))
            {
                MessageBox.Show("Please Select Record.");
                return;
            }

            txtCode.Text = editByCode;
            txtName.Text = lstCategory.SelectedItems[0].SubItems[2].Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            editByCode = lstCategory.SelectedItems[0].SubItems[1].Text;
            if (string.IsNullOrWhiteSpace(editByCode))
            {
                MessageBox.Show("Please Select Record.");
                return;
            }
            var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                      "Confirm Delete!!",
                                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                model = model.Where(res => res.CategoryCode != editByCode).ToList();
                BindingListRecord();
                btnClear.PerformClick();
            }            
        }

        void BindingListRecord()
        {
            lstCategory.Items.Clear();

            foreach (var item in model)
            {
                item.No = model.IndexOf(item) + 1;
                string[] arr = new string[3];
                arr[0] = item.No.ToString();
                arr[1] = item.CategoryCode;
                arr[2] = item.CategoryName;
                ListViewItem listViewItem = new ListViewItem(arr);
                lstCategory.Items.Add(listViewItem);
            }
        }
    }
}
