namespace Lab07Session04.Models
{
    public class NxvEmployee
    {
        public int NxvId { get; set; }              // Mã nhân viên
        public string NxvName { get; set; }         // Họ tên
        public DateTime NxvBirthDay { get; set; }   // Ngày sinh
        public string NxvEmail { get; set; }        // Email
        public string NxvPhone { get; set; }        // Số điện thoại
        public decimal NxvSalary { get; set; }      // Lương
        public bool NxvStatus { get; set; }         // Trạng thái (true = đang làm việc, false = nghỉ việc)

    }
}