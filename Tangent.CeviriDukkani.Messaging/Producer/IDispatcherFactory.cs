namespace Tangent.CeviriDukkani.Messaging.Producer {
    public interface IDispatcherFactory {
        IDispatchCommits CreateDispatcher();
    }
}