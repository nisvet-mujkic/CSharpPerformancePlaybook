namespace CSharpPerformancePlaybook.Code
{
    public class ContentCreator
    {
        private readonly Dictionary<Platform, Func<Content>> _dict = new()
            {
                { Platform.Pluralsight, () => new PluralsightContent()},
                { Platform.Udemy, () => new UdemyContent() },
                { Platform.Udacity, () => new UdacityContent() },
                { Platform.Coursera, () => new CourseraContent() }
            };

        public Content CreateUsingIfs()
        {
            var platform = Platform.Coursera;

            if (platform == Platform.Pluralsight)
            {
                return new PluralsightContent();
            }
            else if (platform == Platform.Udemy)
            {
                return new UdemyContent();
            }
            else if (platform == Platform.Udacity)
            {
                return new UdacityContent();
            }
            else if (platform == Platform.Coursera)
            {
                return new CourseraContent();
            }
            else
            {
                return new Unknown();
            }
        }

        public Content CreateUsingReflection() => _dict.TryGetValue(Platform.Coursera, out var instance)
                ? instance()
                : new Unknown();
    }

    public enum Platform
    {
        Pluralsight = 1,
        Udemy,
        Udacity,
        Coursera
    }

    public abstract class Content
    {
        public abstract string Title { get; set; }
    }

    public class PluralsightContent : Content
    {
        public override string Title { get; set; } = "Pluralsight";
    }

    public class UdemyContent : Content
    {
        public override string Title { get; set; } = "Udemy";
    }

    public class UdacityContent : Content
    {
        public override string Title { get; set; } = "Udacity";
    }

    public class CourseraContent : Content
    {
        public override string Title { get; set; } = "Coursera";
    }

    public class Unknown : Content
    {
        public override string Title { get; set; } = "Unknown";
    }
}