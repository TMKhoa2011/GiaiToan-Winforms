using System;
using System.Windows.Forms;

namespace GiaiToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ====================================================
        // BÀI 1: GIẢI PHƯƠNG TRÌNH BẬC 1 (ax + b = 0)
        // ====================================================
        private void btnGiaiPT1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
            {
                MessageBox.Show("Vui lòng nhập đúng số cho a và b!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (a == 0)
            {
                if (b == 0)
                    lblKetQua1.Text = "Kết quả: Phương trình có vô số nghiệm.";
                else
                    lblKetQua1.Text = "Kết quả: Phương trình vô nghiệm.";
            }
            else
            {
                double x = -b / a;
                lblKetQua1.Text = $"Kết quả: Phương trình có nghiệm x = {x}";
            }
        }

        private void button1_Click(object sender, EventArgs e) => btnGiaiPT1_Click(sender, e);
        private void btnGiaiPT1_Click_1(object sender, EventArgs e) => btnGiaiPT1_Click(sender, e);

        // ====================================================
        // BÀI 2: TÌM SỐ LỚN NHẤT TRONG 2 SỐ NGUYÊN DƯƠNG
        // ====================================================
        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNum1.Text, out int num1) || !int.TryParse(txtNum2.Text, out int num2) || num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("Vui lòng nhập 2 số NGUYÊN DƯƠNG (>0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (num1 > num2)
                lblKetQua2.Text = $"Kết quả: Số lớn nhất là {num1}";
            else if (num2 > num1)
                lblKetQua2.Text = $"Kết quả: Số lớn nhất là {num2}";
            else
                lblKetQua2.Text = "Kết quả: Hai số bằng nhau.";
        }

        private void button2_Click(object sender, EventArgs e) => btnSoSanh_Click(sender, e);
        private void btnSoSanh_Click_1(object sender, EventArgs e) => btnSoSanh_Click(sender, e);

        // ====================================================
        // BÀI 3: TÍNH TỔNG, HIỆU, TÍCH CỦA 2 SỐ NGUYÊN DƯƠNG
        // ====================================================
        private void btnTinhToan_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtX.Text, out int x) || !int.TryParse(txtY.Text, out int y) || x <= 0 || y <= 0)
            {
                MessageBox.Show("Vui lòng nhập 2 số NGUYÊN DƯƠNG (>0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tong = x + y;
            int hieu = x - y;
            long tich = (long)x * y;

            lblKetQua3.Text = $"Tổng: {tong}  |  Hiệu: {hieu}  |  Tích: {tich}";
        }

        private void button3_Click(object sender, EventArgs e) => btnTinhToan_Click(sender, e);
        private void btnTinhToan_Click_1(object sender, EventArgs e) => btnTinhToan_Click(sender, e);

        // ====================================================
        // BÀI 4: TÍNH TỔNG BÌNH PHƯƠNG CỦA 2 SỐ
        // ====================================================
        private void btnTongBP_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtN1.Text, out double n1) || !double.TryParse(txtN2.Text, out double n2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = n1 * n1 + n2 * n2;
            lblKetQua4.Text = $"Kết quả: {n1}² + {n2}² = {result}";
        }

        private void button4_Click(object sender, EventArgs e) => btnTongBP_Click(sender, e);
        private void btnTongBP_Click_1(object sender, EventArgs e) => btnTongBP_Click(sender, e);

        // ====================================================
        // BÀI 5: IN SỐ ĐẢO NGƯỢC CỦA SỐ DƯƠNG CÓ 2 CHỮ SỐ
        // ====================================================
        private void btnKiemTra5_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN5.Text, out int n) || n < 10 || n > 99)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương CÓ 2 CHỮ SỐ (từ 10 đến 99)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int chuc = n / 10;
            int donVi = n % 10;
            int daoNguoc = donVi * 10 + chuc;

            lblKetQua5.Text = $"Kết quả: Số đảo ngược của {n} là {daoNguoc}";
        }

        private void button5_Click(object sender, EventArgs e) => btnKiemTra5_Click(sender, e);
        private void btnKiemTra5_Click_1(object sender, EventArgs e) => btnKiemTra5_Click(sender, e);
        private void btnKiemTra5_Click_2(object sender, EventArgs e) => btnKiemTra5_Click(sender, e);

        // ====================================================
        // BÀI 6: ĐỔI GIỜ, PHÚT, GIÂY SANG TỔNG SỐ GIÂY
        // (Nhập 3 ô: txtGio6, txtPhut6, txtGiay6 HOẶC nhập 1 ô txtN6 dạng gio,phut,giay)
        // ====================================================
        private void btnTinh6_Click(object sender, EventArgs e)
        {
            int gio = 0, phut = 0, giay = 0;
            bool valid = false;

            // Kiểm tra nếu giao diện dùng 3 ô TextBox riêng lẻ
            if (Controls.Find("txtGio6", true).Length > 0)
            {
                TextBox txtGio = (TextBox)Controls.Find("txtGio6", true)[0];
                TextBox txtPhut = (TextBox)Controls.Find("txtPhut6", true)[0];
                TextBox txtGiay = (TextBox)Controls.Find("txtGiay6", true)[0];

                if (int.TryParse(txtGio.Text, out gio) && int.TryParse(txtPhut.Text, out phut) && int.TryParse(txtGiay.Text, out giay)
                    && gio >= 0 && phut >= 0 && giay >= 0)
                {
                    valid = true;
                }
            }
            // Nếu giao diện dùng 1 ô TextBox txtN6 (nhập ví dụ: 1,30,45)
            else if (txtGio6 != null && !string.IsNullOrWhiteSpace(txtGio6.Text))
            {
                string[] parts = txtGio6.Text.Split(',');
                if (parts.Length == 3 && int.TryParse(parts[0].Trim(), out gio) && int.TryParse(parts[1].Trim(), out phut) && int.TryParse(parts[2].Trim(), out giay)
                    && gio >= 0 && phut >= 0 && giay >= 0)
                {
                    valid = true;
                }
            }

            if (!valid)
            {
                MessageBox.Show("Vui lòng nhập Giờ, Phút, Giây hợp lệ (số không âm)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tongGiay = gio * 3600 + phut * 60 + giay;
            lblKetQua6.Text = $"Kết quả: {gio}h {phut}m {giay}s = {tongGiay} giây";
        }

        private void button6_Click(object sender, EventArgs e) => btnTinh6_Click(sender, e);
        private void btnTinh6_Click_1(object sender, EventArgs e) => btnTinh6_Click(sender, e);
        private void btnTinh6_Click_2(object sender, EventArgs e) => btnTinh6_Click(sender, e);

        // ====================================================
        // BÀI 7: TÍNH DIỆN TÍCH HÌNH TRÒN (S = π * r²)
        // ====================================================
        private void btnTinh7_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtR7.Text, out double r) || r <= 0)
            {
                MessageBox.Show("Vui lòng nhập bán kính r là số dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double dienTich = Math.PI * r * r;
            lblKetQua7.Text = $"Kết quả: Diện tích hình tròn = {Math.Round(dienTich, 2)}";
        }

        // ====================================================
        // BÀI 8: TÍNH DIỆN TÍCH HÌNH VUÔNG (S = a²)
        // ====================================================
        private void btnTinh8_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA8.Text, out double a) || a <= 0)
            {
                MessageBox.Show("Vui lòng nhập cạnh a là số dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double dienTich = a * a;
            lblKetQua8.Text = $"Kết quả: Diện tích hình vuông = {dienTich}";
        }

        // ====================================================
        // BÀI 9: TÍNH CHU VI HÌNH TRÒN (C = 2 * π * r)
        // ====================================================
        private void btnTinh9_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtR9.Text, out double r) || r <= 0)
            {
                MessageBox.Show("Vui lòng nhập bán kính r là số dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double chuVi = 2 * Math.PI * r;
            lblKetQua9.Text = $"Kết quả: Chu vi hình tròn = {Math.Round(chuVi, 2)}";
        }

        // ====================================================
        // BÀI 10: TÍNH CHU VI HÌNH THANG CÂN
        // ====================================================
        private void btnTinh10_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtA10.Text, out double a) ||
                !double.TryParse(txtB10.Text, out double b) ||
                !double.TryParse(txtH10.Text, out double h) ||
                a <= 0 || b <= 0 || h <= 0)
            {
                MessageBox.Show("Vui lòng nhập các kích thước là số dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (a >= b)
            {
                MessageBox.Show("Đáy lớn (b) phải lớn hơn đáy nhỏ (a)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double canhBen = Math.Sqrt(h * h + Math.Pow((b - a) / 2.0, 2));
            double chuVi = a + b + 2 * canhBen;

            lblKetQua10.Text = $"Kết quả: Cạnh bên = {Math.Round(canhBen, 2)} | Chu vi = {Math.Round(chuVi, 2)}";
        }

       
    }
}