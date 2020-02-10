using System;
using System.Activities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;


namespace PZone.Xrm.Workflow
{
    /// <summary>
    /// Контекст выполнения действия процесса.
    /// </summary>
    public class Context
    {
        private readonly Lazy<IWorkflowContext> _context;
        private readonly Lazy<IOrganizationService> _service;
        private readonly Lazy<IOrganizationService> _systemService;
        private readonly Lazy<ITracingService> _tracingService;

        /// <summary>
        /// Флаг тестовая организация или нет
        /// </summary>
        public Lazy<bool> IsTestingOrganization;


        /// <summary>
        /// Конструтор класса.
        /// </summary>
        /// <param name="activityContext">Контекст выполнения действия процесса.</param>
        public Context(CodeActivityContext activityContext)
        {
            SourceActivityContext = activityContext;
            _context = new Lazy<IWorkflowContext>(() => SourceActivityContext.GetContext());
            _service = new Lazy<IOrganizationService>(() => SourceActivityContext.GetService());
            _systemService = new Lazy<IOrganizationService>(() => SourceActivityContext.GetService(null));
            _tracingService = new Lazy<ITracingService>(() => SourceActivityContext.GetTracingService());
        }


        /// <summary>
        /// Исходный стандартный контекст выполнения действия процесса.
        /// </summary>
        public CodeActivityContext SourceActivityContext { get; }


        /// <summary>
        /// Ссылка на экземпляр CRM-сервиса, запусщенного от имени пользователя, инициировавшего запуск действия процесса.
        /// </summary>
        public IOrganizationService Service => _service.Value;


        /// <summary>
        /// Ссылка на экземпляр CRM-сервиса, запусщенного от имени системного пользователя (имеющего полный доступ к системе).
        /// </summary>
        public IOrganizationService SystemService => _systemService.Value;


        /// <summary>
        /// Cервис трассировки.
        /// </summary>
        public ITracingService TracingService => _tracingService.Value;


        /// <summary>
        /// Исходный стандартный контекст действия процесса.
        /// </summary>
        public IWorkflowContext SourceContext => _context.Value;


        /// <summary>
        /// Системное имя основной сущности.
        /// </summary>
        public string EntityName => _context.Value.PrimaryEntityName;


        /// <summary>
        /// Идентификатор основной сущности.
        /// </summary>
        public Guid EntityId => _context.Value.PrimaryEntityId;
    }
}