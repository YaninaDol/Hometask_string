using System;
using System.Text;
namespace New_Language_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.Et harum quidem rerum facilis est et expedita distinctio.Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.";
            Console.WriteLine(text);
            Console.WriteLine();

            string[] res = text.Split(" ");

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i].Length < 3)
                {
                    res[i] = "secret";
                    str.Append(res[i] + " ");

                }
                else
                {
                    str.Append(res[i] + " ");
                }

            }


            string str1 = str.ToString();

            string[] res1 = str1.Split(" ");

            StringBuilder stroka = new StringBuilder();
            for (int i = 0; i < res1.Length; i++)
            {
                if (res1[i].Length == 3)
                {
                    if (res1[i].IndexOf(",") != -1)
                    {
                        res1[i] = "secret,";
                    }
                    if (res1[i].IndexOf(".") != -1)
                    {
                        res1[i] = "secret.";
                    }
                    if (res1[i].IndexOf(":") != -1)
                    {
                        res1[i] = "secret:";
                    }

                    stroka.Append(res1[i] + " ");

                }
                else
                {
                    stroka.Append(res1[i] + " ");
                }

            }

            string text2 = stroka.ToString();

            Console.WriteLine();
            Console.WriteLine(text2);
        }
    }
}
