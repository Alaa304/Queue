// See https://aka.ms/new-console-template for more information

Queue<PrintJob> job = new Queue<PrintJob>();
job.Enqueue(new PrintJob("documentation.docx", 2));
job.Enqueue(new PrintJob("user_stories.pdf", 2));
job.Enqueue(new PrintJob("report.xlsx",2));
job.Enqueue(new PrintJob("bdget.xlsx", 2));

Random random = new Random();
while(job.Count > 0)
{
    Console.ForegroundColor=ConsoleColor.Magenta;
    Console.BackgroundColor = ConsoleColor.Gray;
    var jobs = job.Dequeue();
    Console.WriteLine($"Printing  [{jobs}]");
    System.Threading.Thread.Sleep(random.Next(1,4)*1000);
}


class PrintJob
{
    private readonly string _file;
    private readonly int _copies;

    public PrintJob(string file, int copies)
    {
        _file = file;
        _copies = copies;
    }
    public override string ToString()
    {
        return $"{_file} X #{_copies} Copies";
    }
}