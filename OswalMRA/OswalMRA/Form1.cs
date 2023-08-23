using PresentationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OswalMRA
{
    public partial class Form1 : Form
    {
        private StatusList _StatusList;

        private ListSelectionWrapper<Status> StatusSelections;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _StatusList = new StatusList();

            _StatusList.Add(new Status(1, "New"));
            _StatusList.Add(new Status(2, "Loaded"));
            _StatusList.Add(new Status(3, "Inserted"));
            Status UpdatedStatus = new Status(4, "Updated");
            _StatusList.Add(UpdatedStatus);
            _StatusList.Add(new Status(5, "Deleted"));

            StatusSelections = new ListSelectionWrapper<Status>(_StatusList, "Name");

            cmbIListDataSource.DataSource = StatusSelections;
            cmbIListDataSource.DisplayMemberSingleItem = "Name";
            cmbIListDataSource.DisplayMember = "NameConcatenated";
            cmbIListDataSource.ValueMember = "Selected";

            cmbIListDataSource.CheckBoxItems[3].DataBindings.DefaultDataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;
            cmbIListDataSource.DataBindings.DefaultDataSourceUpdateMode
                = DataSourceUpdateMode.OnPropertyChanged;
        }
    }

    public class Status
    {
        public Status(int id, string name)
        {
            _Id = id;
            _Name = name;
        }

        private int _Id;
        private string _Name;

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        /// <summary>
        /// Now used to return the Name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
    /// <summary>
    /// Class used for demo purposes. A list of "Status". 
    /// This represents the custom "IList" datasource of anything listed in a CheckBoxComboBox.
    /// </summary>
    public class StatusList : List<Status>
    {
    }

}
