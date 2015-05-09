using WeirdTextLibrary.Statistics;

namespace ConsoleDemoApp
{
    /// <summary>
    /// Статистика символов в текстовом файле
    /// </summary>
    public class CustomCharStatistic : BaseStatistic
    {
        public CustomCharStatistic(int count) { Count = count; }

        public int Count { get; protected set; }
    }
}
