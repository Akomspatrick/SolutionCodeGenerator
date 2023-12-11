﻿
using System.Text;
using System.Xml.Linq;

namespace CleanAppFilesGenerator
{
    public class GenerateCQRSHandlerClass
    {
        // public static string GenerateCreateCommandhandler(Type type, string name_space)
        // {
        //     var Output = new StringBuilder();
        //     Output.Append(ProduceCreateCommandHandlerHeader(name_space, type.Name));
        //     Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
        //     Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
        //     return Output.ToString();
        // }
        // public static string GenerateDeleteCommandHandler(Type type, string name_space)
        // {
        //     var Output = new StringBuilder();
        //     Output.Append(ProduceDeleteCommandHandlerHeader(name_space, type.Name));
        //     Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
        //     Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
        //     return Output.ToString();
        // }

        // public  static string GenerateGetAllQueryHandler(Type type, string name_space)
        // {
        //     var Output = new StringBuilder();
        //     Output.Append(ProduceGetAllQueryHandlerHeader(name_space, type.Name));
        //     Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
        //     Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
        //     return Output.ToString();
        // }
        //public static string GenerateGetQueryHandler(Type type, string name_space)
        // {
        //     var Output = new StringBuilder();
        //     Output.Append(ProduceGetQueryHandlerHeader(name_space, type.Name));
        //     Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
        //     Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
        //     return Output.ToString();
        // }
        //public static string GenerateUpdateCommandhandler(Type type, string name_space)
        // {
        //     var Output = new StringBuilder();
        //     Output.Append(ProduceUpdateCommandhandler(name_space, type.Name));
        //     Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
        //     Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
        //     return Output.ToString();
        // }


        public static string GenerateCQRSHandler(Type type, string name_space, Func<string, string, string> producehandelerheader)
        {
            var Output = new StringBuilder();
            Output.Append(producehandelerheader(name_space, type.Name));
            Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }



        public static string ProduceCreateCommandHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                         $"using {name_space}.Application.Contracts.Logging;\n" +
                          $"using LanguageExt;\nusing MediatR;\n" +
                          $"using {name_space}.Application.CQRS.Model.Commands;\n" +
                          $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                          $"{GeneralClass.newlinepad(4)}public  class Create{entityName}CommandHandler  :  IRequestHandler<Create{entityName}Command, Either<GeneralFailure, int>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Create{entityName}CommandHandler> _logger;" +
                          $"{GeneralClass.newlinepad(8)}public Create{entityName}CommandHandler(IUnitOfWork unitOfWork, IAppLogger<Create{entityName}CommandHandler> logger)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, int>> Handle(Create{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
                          $"{GeneralClass.newlinepad(8)}}}");

        }

        public static string ProduceDeleteCommandHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                             $"using {name_space}.Application.Contracts.Logging;\n" +
                              $"using {name_space}.Application.CQRS.Model.Commands;\n" +
                          $"using LanguageExt;\nusing MediatR;\n" +
                          $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                          $"{GeneralClass.newlinepad(4)}public  class Delete{entityName}CommandHandler  :  IRequestHandler<Delete{entityName}Command, Either<GeneralFailure, int>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Create{entityName}CommandHandler> _logger;" +
                          $"{GeneralClass.newlinepad(8)}public Delete{entityName}CommandHandler(IUnitOfWork unitOfWork, IAppLogger<Delete{entityName}CommandHandler> logger)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, int>> Handle(Delete{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
                          $"{GeneralClass.newlinepad(8)}}}");



        }



        public static string ProduceGetAllQueryHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using {name_space}.Application.Contracts.Logging;\n" +
                 $"using {name_space}.Application.CQRS.Model.Commands;\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
               $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"{GeneralClass.newlinepad(4)}public  class GetAll{entityName}QueryHandler  :  IRequestHandler<GetAll{entityName}Query, Either<GeneralFailure, IEnumerable<Application{entityName}ResponseDTO>>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<GetAll{entityName}QueryHandler> _logger;" +
               $"{GeneralClass.newlinepad(8)}public GetAll{entityName}QueryHandler(IUnitOfWork unitOfWork, IAppLogger<GetAll{entityName}QueryHandler> logger)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, IEnumerable<Application{entityName}ResponseDTO>>> Handle(GetAll{entityName}Query request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceGetQueryHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using {name_space}.Application.Contracts.Logging;\n" +
                 $"using {name_space}.Application.CQRS.Model.Commands;\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
               $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"{GeneralClass.newlinepad(4)}public  class Get{entityName}QueryHandler  :  IRequestHandler<Get{entityName}Query, Either<GeneralFailure, Application{entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Get{entityName}QueryHandler> _logger;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}QueryHandler(IUnitOfWork unitOfWork, IAppLogger<Get{entityName}QueryHandler> logger)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, Application{entityName}ResponseDTO>> Handle(Get{entityName}Query request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceGetByIdQueryHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using {name_space}.Application.Contracts.Logging;\n" +
                 $"using {name_space}.Application.CQRS.Model.Commands;\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
               $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"{GeneralClass.newlinepad(4)}public  class Get{entityName}ByIdQueryHandler  :  IRequestHandler<Get{entityName}ByIdQuery, Either<GeneralFailure, Application{entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Get{entityName}ByIdQueryHandler> _logger;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}ByIdQueryHandler(IUnitOfWork unitOfWork, IAppLogger<Get{entityName}ByIdQueryHandler> logger)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, Application{entityName}ResponseDTO>> Handle(Get{entityName}ByIdQuery request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(8)}}}");
        }

        public static string ProduceGetByGuidQueryHandlerHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using {name_space}.Application.Contracts.Logging;\n" +
                 $"using {name_space}.Application.CQRS.Model.Commands;\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
               $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"{GeneralClass.newlinepad(4)}public  class Get{entityName}ByGuidQueryHandler  :  IRequestHandler<Get{entityName}ByGuidQuery, Either<GeneralFailure, Application{entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Get{entityName}ByGuidQueryHandler> _logger;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}ByGuidQueryHandler(IUnitOfWork unitOfWork, IAppLogger<Get{entityName}ByGuidQueryHandler> logger)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, Application{entityName}ResponseDTO>> Handle(Get{entityName}ByGuidQuery request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceUpdateCommandhandler(string name_space, string entityName)
        {

            return ($"using {name_space}.Domain.Interfaces;\n" +
                         $"using {name_space}.Application.Contracts.Logging;\n" +
                          $"using {name_space}.Application.CQRS.Model.Commands;\n" +
                          $"using LanguageExt;\nusing MediatR;\n" +
                          $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                          $"{GeneralClass.newlinepad(4)}public  class Update{entityName}CommandHandler  :  IRequestHandler<Update{entityName}Command, Either<GeneralFailure, int>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}private readonly IAppLogger<Update{entityName}CommandHandler> _logger;" +
                          $"{GeneralClass.newlinepad(8)}public Update{entityName}CommandHandler(IUnitOfWork unitOfWork, IAppLogger<Update{entityName}CommandHandler> logger)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, int>> Handle(Update{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
                          $"{GeneralClass.newlinepad(8)}}}");



        }
    }
}