using StudentManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.FORMS
{
    public partial class SubRoomForm : Form
    {
        public SubRoomForm()
        {
            InitializeComponent();
        }

        private void SubRoomForm_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbRoomType.Items.AddRange(new string[] { "Lab", "Hall" });
        }

        private void LoadData()
        {
            dataGridViewRooms.DataSource = SubRoomController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedItem == null)
            {
                MessageBox.Show("Please enter room name and select room type.");
                return;
            }

            var room = new SubRoom
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? ""
            };

            SubRoomController.Insert(room);
            LoadData();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
                return;

            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedItem == null)
            {
                MessageBox.Show("Please enter room name and select room type.");
                return;
            }

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            if (selectedRow.Cells["RoomId"].Value == null) return;

            var room = new SubRoom
            {
                RoomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value),
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString() ?? ""
            };

            SubRoomController.Update(room);
            LoadData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
                return;

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            if (selectedRow.Cells["RoomId"].Value == null) return;

            int id = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);
            SubRoomController.Delete(id);
            LoadData();
            ClearFields();
        }

        private void dataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
                return;

            var row = dataGridViewRooms.SelectedRows[0];

            if (row.Cells["RoomName"].Value != null)
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString() ?? "";

            if (row.Cells["RoomType"].Value != null)
                cmbRoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
        }

        private void ClearFields()
        {
            txtRoomName.Clear();
            cmbRoomType.SelectedIndex = -1;
        }
    }
}
