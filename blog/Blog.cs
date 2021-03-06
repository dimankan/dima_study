using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Blog
    {
        private Blog(int id, string title, string text, DateTime createdDate, DateTime updatedDate)
        {
            Id = id;
            Title = title;
            Text = text;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }

        public int Id { get; }

        public string Title { get; }

        public string Text { get; }

        public DateTime CreatedDate { get; }

        public DateTime UpdatedDate { get; }

        public static Blog Create(string title, string text)
        {
            var blog = new Blog(0, title, text, DateTime.Now, DateTime.Now);
            return blog;
        }

        public Blog UpdateTitle(string newTitle)
        {
            return new Blog(0, newTitle, Text, this.CreatedDate, DateTime.Now);
        }

        public Blog UpdateText(string newText)
        {
            return new Blog(0, Title, newText, this.CreatedDate, DateTime.Now);
        }

        public string Show()
        {
            string result = $"-------------{Title}-------------{Environment.NewLine}{Text}{Environment.NewLine}{Environment.NewLine}Дата создания: {CreatedDate}{Environment.NewLine}Дата последнего изменения: {UpdatedDate}";
            return result;
        }
    }
}
