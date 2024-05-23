﻿using System.ComponentModel.DataAnnotations;

namespace HotelManagementAPI.DTO.Request
{
    public class NhanVienUpdateDto
    {

        [MaxLength(100)]
        [Required]
        public string HoTen { get; set; } = null!;

        public DateTime? NgaySinh { get; set; }

        [MaxLength(3)]
        public string? GioiTinh { get; set; }

        [MaxLength(100)]
        public string? DiaChi { get; set; }

        [MaxLength(10)]
        [Required]
        [RegularExpression(@"^[0-9]*$")]
        public string? Sdt { get; set; }

        [MaxLength(12)]
        [RegularExpression(@"^[0-9]*$")]
        public string? Cccd { get; set; }

        [Required]
        public bool QuanLy { get; set; }
    }
}
