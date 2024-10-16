namespace QFramework.Example8
{
    public class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ICounterModel>().Count.Value++;
        }
    }
}
