using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TreeViewUpdate.Entities;
using TreeViewUpdate.TreeViewModels;

namespace TreeViewUpdate
{
    public partial class EditNodeForm : Form
    {
        private EFContext _context { get; set; }
        private TreeNode _node { get; set; }
        private List<TreeNodeModel> _nodes { get; set; }
        public EditNodeForm(EFContext context, TreeNode node, List<TreeNode> nodes)
        {
            InitializeComponent();
            _nodes = nodes.Select(x => new TreeNodeModel { 
                Id = int.Parse(x.Name),
                Name = x.Text
            }).ToList();

            this._node = node;
            this._context = context;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this._node.Name);

            var el = this._context.Categories.FirstOrDefault(x => x.Id == id);

            if (!string.IsNullOrEmpty(this.txtName.Text))
            {
                el.Name = this.txtName.Text;

                if (cbParents.SelectedItem != null)
                {
                    var cat = this.cbParents.SelectedItem as TreeNodeModel;
                    var parentEl = this._context.Categories.FirstOrDefault(x => x.Id == cat.Id);
                    el.Parent = parentEl;
                }
                else 
                {
                    el.ParentId = null;
                }
                this._context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Поле НАЗВА пусте!");
            }

        }

        private void EditNodeForm_Load(object sender, EventArgs e)
        {
            this.txtName.Text = this._node.Text;
            foreach (var item in this._nodes) 
            {
                this.cbParents.Items.Add(item);
            }

            var el = this._nodes.FirstOrDefault(x => x.Id == (this._node.Tag as Entities.TreeViewUpdate).ParentId);
            if (el != null) 
            {
                foreach (var item in this.cbParents.Items) 
                {
                    if ((item as TreeNodeModel).Id == el.Id) 
                    {
                        this.cbParents.SelectedItem = item;
                    }
                }
            }
        }
    }
}
