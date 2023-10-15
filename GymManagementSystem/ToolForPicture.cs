using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem
{
    internal class ToolForPicture
    {
       

        //String lưu địa chỉ folder chứa hình ảnh
        private static string pathWorkOut = @"..\..\..\..\WorkOut";
        private static string pathTrainer = @"..\..\..\..\Trainer";
        private static string pathAvatar = @"..\..\..\..\Avatar";
        private string path;

        public ToolForPicture(Type type)
        {
            if (type == Type.workOut)
                path = pathWorkOut;
            else if (type == Type.trainer)
                path = pathTrainer;
            else 
                path = pathAvatar;
        }
        public enum Type
        {
            workOut,
            trainer,
            avatar
        }
        public string GetFolderPath()
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string folderPath = string.Format(System.IO.Path.Combine(sCurrentDirectory, path));
            return folderPath;
        }

        //Xóa hình
        public void DeleteDirectory(string folderPath, string fileName)
        {
            string fileNamePng = fileName + ".png";
            string fullPathPng = Path.Combine(folderPath, fileNamePng);

            string fileNameJpg = fileName + ".jpg";
            string fullPathJpg = Path.Combine(folderPath, fileNameJpg);

            if (File.Exists(fullPathPng))
            {
                File.Delete(fullPathPng);
            }
            if (File.Exists(fullPathJpg))
            {
                File.Delete(fullPathJpg);
            }

        }

        //Lưu hình đại diện từ picturbox về với name mới
        public void SavePicture(string name, OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien)
        {
            string fileExtension = Path.GetExtension(ofdHinhDaiDien.FileName).ToLowerInvariant();

            if (fileExtension != ".jpg" && fileExtension != ".png")
            {
                // Thông báo lỗi nếu ko phải file png với jpg
                MessageBox.Show("File ảnh không hợp lệ. Chọn ảnh jpg hoặc png.");
                return;
            }

            string fileName = string.Format($"{name}{fileExtension}");
            string folderPath = GetFolderPath();
            string fullPath = Path.Combine(folderPath, fileName);

            DeleteDirectory(folderPath, $"{name}"); // Xóa ảnh cũ

            ptcHinhDaiDien.Image.Save(fullPath, fileExtension == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png);
        }

        //Mở file để lấy hình đưa vào picturebox
        public bool AddPicture(OpenFileDialog ofdHinhDaiDien, PictureBox ptcHinhDaiDien)
        {
            ofdHinhDaiDien.Filter = "PImage Files (*.jpg, *.png)|*.jpg;*.png";
            try
            {
                if (ofdHinhDaiDien.ShowDialog() == DialogResult.OK)
                {
                    ptcHinhDaiDien.Image = new Bitmap(ofdHinhDaiDien.FileName);
                }
                return true;
            }
            catch
            {
                return false;
            }

        }

        private static void Assigned(string filename, PictureBox ptcHinhDaiDien)
        {
            Bitmap? bitmap = null;
            bitmap?.Dispose();
            ptcHinhDaiDien.Image?.Dispose();

            using (Bitmap tempImage = new Bitmap(filename, true)) //Giúp k bị lỗi không thể truy cập file đang hoạt động khi xóa
            {
                bitmap = new Bitmap(tempImage);
                ptcHinhDaiDien.Image = bitmap;
            }
        }

        //Đưa hình đại diện lên DataGridView
        public void GetPicture(string name, PictureBox ptcHinhDaiDien)
        {
            string folderPath = GetFolderPath();
            string imagePath = string.Format(@$"{folderPath}\{name}");
            string png = imagePath + ".png";
            string jpg = imagePath + ".jpg";

            if (File.Exists(png))
            {
                Assigned(png, ptcHinhDaiDien);
            }
            else if (File.Exists(jpg))
            {
                Assigned(jpg, ptcHinhDaiDien);
            }
        }
      
  
}
}
