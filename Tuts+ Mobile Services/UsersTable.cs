using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuts__Mobile_Services
{
    class UsersTable
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserID { get; set; }

        [JsonProperty(PropertyName = "user_email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

    }
}
