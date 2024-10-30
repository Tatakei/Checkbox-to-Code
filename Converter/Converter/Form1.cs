namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            // Add Code inside of the @"...";
            string templateCode = @"I am a fan of ${a1} ${b2} ${c3} ${d4} and ${e5}.";
            var replacements = new Dictionary<string, string>
        {
            // Add more checkboxes here
            {"${a1}", a1.Checked ? "Donuts," : "" },
            {"${b2}", b2.Checked ? "Chicken Nuggets," : "" },
            {"${c3}", c3.Checked ? "Tacos," : "" },
            {"${d4}", d4.Checked ? "KFC cole slaw," : "" },
            {"${e5}", e5.Checked ? "Salad" : "" },
        };

            string processedCode = ProcessTemplateCode(templateCode, replacements);

            // Display the processed code in the desired manner, for example, in a MessageBox.
            MessageBox.Show(processedCode);
        }

        private string ProcessTemplateCode(string templateCode, Dictionary<string, string> replacements)
        {
            foreach (var replacement in replacements)
            {
                templateCode = templateCode.Replace(replacement.Key, replacement.Value);
            }

            return templateCode;
        }
    }
}