using BlazorServerAppDemo.Models.Policy_Type;

namespace BlazorServerAppDemo.Models
{
    public class Policy
    {
        public Home Home { get; set; }

        public List<Motor> Motor { get; set; }

        public List<Life> Life { get; set; }

    }
}
