namespace QFramework.Example6
{
    public class IncreaseCountCommand : AbstractCommand
    {
        protected override void OnExecute()
        {
            this.GetModel<CounterAppModel>().Count++;
            this.SendEvent<CountChangeEvent>(); // ++
        }
    }
}
