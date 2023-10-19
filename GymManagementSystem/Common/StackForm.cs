using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    internal static class StackForm
    {
        static private List<Form> forms = new List<Form>();

        //Lưu form trang chủ
        private static FHomeUser homeUser;


        public static FHomeUser HomeUser { get => homeUser; set => homeUser = value; }

        //Thêm form vào stack
        static public void Add(Form form)
        {
            forms.Add(form);
        }

        //Xóa form
        static public void RemoveForm()
        {
            forms[forms.Count - 1].Close();
            forms.RemoveAt(forms.Count - 1);
        }

        //Thực hiện quay lui form
        static public void Back()
        {
            if (forms.Count > 0)
            {
                RemoveForm();
                
            }
        }


        //Xóa tất cả các form
        static public void ClearAll()
        {
            foreach (var form in forms)
            {
                form.Close();
            }
            forms.Clear();
        }
    }
}
