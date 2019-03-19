using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TracNghiemDB
{
    public class Member_Info
    {
        #region Variables
        Guid _id, _createdby, _modifiedby;
        string _name, _username, _password, _picture;
        DateTime _createddate, _modifieddate;
        #endregion

        #region Properties
        public Guid Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Picture { get => _picture; set => _picture = value; }
        public DateTime CreatedDate { get => _createddate; set => _createddate = value; }
        public Guid CreatedBy { get => _createdby; set => _createdby = value; }

        #endregion

        #region Constructors
        public Member_Info() { }
        public Member_Info(Guid _id)
        {
            DBContext db = new DBContext();
            db.SetCommandText("SELECT * FROM Member", CommandType.Text);
            DataTable t = new DataTable();
            db.FillDataTable(t);
            if (t.Rows.Count > 0)
            {
                this._id = _id;
                this._name = t.Rows[0]["Name"].ToString();
            }
        }
        #endregion

        #region Methods
        #endregion

        #region Destructor
        #endregion
    }
}
