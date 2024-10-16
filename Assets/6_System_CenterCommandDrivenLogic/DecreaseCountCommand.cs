namespace QFramework.Example6
{
    public class DecreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterAppModel>().Count--;
            this.SendEvent<CountChangeEvent>(); // ++
        }
    }
}