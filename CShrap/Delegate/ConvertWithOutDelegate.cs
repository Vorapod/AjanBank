using Delegate.Model;
namespace Delegate
{
    public abstract class GodOfConvert<TIn, TOut>
    {
        protected abstract TOut Convert(TIn source);
        protected void DoSomeLogicInChild()
        {
            // Method intentionally left empty.
        }
        public abstract TOut OnConvert(TIn source);

    }
    public class ConvertFuckMeToFuckYou : GodOfConvert<FuckMe, FuckYou>
    {
        public override FuckYou OnConvert(FuckMe fuckMe)
        {
            return Convert(fuckMe);
        }

        protected override FuckYou Convert(FuckMe fuckMe)
        {
            DoSomeLogicInChild();
            FuckYou fuckYou = new FuckYou
            {
                Age = fuckMe.Age,
                Name = fuckMe.Name,
                Salary = fuckMe.Salary
            };
            return fuckYou;
        }
    }

}
