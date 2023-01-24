using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreCookieAuthentication.Data {
    public class AppointmentSlot {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string? PatientName { set; get; }

        public string? Text => PatientName;

        [JsonPropertyName("patient")]
        public string? PatientId { set; get; }

        public string Status { get; set; } = "free";
    }
}
