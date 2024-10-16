namespace QFramework.Example8
{
    public class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<ICounterModel>().Count.Value--;
        }
    }
}