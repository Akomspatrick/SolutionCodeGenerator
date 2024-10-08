﻿
using System.Text;
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


        public static string GenerateCQRSHandler(Type type, string name_space, string apiVersion, Func<string, string, string, string> producehandelerheader)
        {
            var Output = new StringBuilder();
            Output.Append(producehandelerheader(name_space, type.Name, apiVersion));
            Output.Append(GeneralClass.newlinepad(4) + GeneralClass.ProduceClosingBrace());
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }



        public static string ProduceCreateCommandHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                         $"using Microsoft.Extensions.Logging;\n" +
                          $"using LanguageExt;\nusing MediatR;\n" +
                          // $"using {name_space}.Application.CQRS.Model.Commands;\n" +
                          //$"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
                          $"using {name_space}.Domain.Errors;\n" +
                          //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                          $"namespace {name_space}.Application.CQRS\n{{" +
                          $"{GeneralClass.newlinepad(4)}public sealed class Create{entityName}CommandHandler  :  IRequestHandler<Create{entityName}Command, Either<GeneralFailure, Guid>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}private readonly ILogger<Create{entityName}CommandHandler> _logger;" +
                          $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
                          $"{GeneralClass.newlinepad(8)}public Create{entityName}CommandHandler(IUnitOfWork unitOfWork, ILogger<Create{entityName}CommandHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, Guid>> Handle(Create{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
                          $"{GeneralClass.newlinepad(12)}//Follow the format below , initial the entity variable by calling the entity Create method;" +
                          $"{GeneralClass.newlinepad(8)}}}//var entity =null; Domain.Entities.{entityName}.Create(request.{GeneralClass.FirstCharSubstringToLower(entityName)}CreateDTO.{entityName}Name, request.{GeneralClass.FirstCharSubstringToLower(entityName)}CreateDTO.Value.GuidId);" +
                          $"return ( await  _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository.AddAsync(entity, cancellationToken)). Map((x) =>  entity.GuidId);");

        }

        public static string ProduceDeleteCommandHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                             $"using Microsoft.Extensions.Logging;\n" +
                              $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
                              $"using {name_space}.Domain.Errors;\n" +
                          $"using LanguageExt;\nusing MediatR;\n" +
                           // $"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                           $"namespace {name_space}.Application.CQRS\n{{" +
                          $"{GeneralClass.newlinepad(4)}public sealed class Delete{entityName}CommandHandler  :  IRequestHandler<Delete{entityName}Command, Either<GeneralFailure, int>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
                          $"{GeneralClass.newlinepad(8)}private readonly ILogger<Delete{entityName}CommandHandler> _logger;" +
                          $"{GeneralClass.newlinepad(8)}public Delete{entityName}CommandHandler(IUnitOfWork unitOfWork, ILogger<Delete{entityName}CommandHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, int>> Handle(Delete{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException(\"Operation Not Allowed \");" +
                          $"{GeneralClass.newlinepad(12)}//return  await _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository.DeleteByGuidAsync(request.Delete{entityName}DTO.guid, cancellationToken);" +
                          $"{GeneralClass.newlinepad(12)}//Old return  await _unitOfWork.{entityName}Repository.DeleteByGuidAsync(request.Delete{entityName}DTO.guid, cancellationToken);" +
                          $"{GeneralClass.newlinepad(8)}}}");



        }



        public static string ProduceGetAllQueryHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using Microsoft.Extensions.Logging;\n" +
                 // $"using {name_space}.Application.CQRS.{entityName}.Queries;\n" +
                 $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
                 $"using {name_space}.Domain.Errors;\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
                //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                $"namespace {name_space}.Application.CQRS\n{{" +
               $"{GeneralClass.newlinepad(4)}public sealed class GetAll{entityName}QueryHandler  :  IRequestHandler<GetAll{entityName}Query, Either<GeneralFailure, IEnumerable<{entityName}ResponseDTO>>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly ILogger<GetAll{entityName}QueryHandler> _logger;" +
                $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
               $"{GeneralClass.newlinepad(8)}public GetAll{entityName}QueryHandler(IUnitOfWork unitOfWork, ILogger<GetAll{entityName}QueryHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, IEnumerable<{entityName}ResponseDTO>>> Handle(GetAll{entityName}Query request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +

               $"{GeneralClass.newlinepad(12)}//List<string> includes = null;// empty list  null;//new List<string>() {"Models"};" +
               $"{GeneralClass.newlinepad(12)}//return (await _unitOfWork.{entityName}Repository" +
               $"{GeneralClass.newlinepad(16)}//.GetAllAsync(s => true, null, null, cancellationToken))" +
               $"{GeneralClass.newlinepad(16)}// .Map(task => task.Select(result => new {entityName}ResponseDTO(result.GuidId, result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, null)));;" +
               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceGetQueryHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using Microsoft.Extensions.Logging;\n" +
                 // $"using {name_space}.Application.CQRS.Model.Queries;\n" +
                 $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
                 $"using {name_space}.Domain.Errors;\n" +

               $"using LanguageExt;\nusing MediatR;\n" +
               //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"namespace {name_space}.Application.CQRS\n{{" +
               $"{GeneralClass.newlinepad(4)}public sealed class Get{entityName}QueryHandler  :  IRequestHandler<Get{entityName}Query, Either<GeneralFailure, {entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly ILogger<Get{entityName}QueryHandler> _logger;" +
                $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}QueryHandler(IUnitOfWork unitOfWork, ILogger<Get{entityName}QueryHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, {entityName}ResponseDTO>> Handle(Get{entityName}Query request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(12)}//List<string> includes = null;// empty list  null;//new List<string>() {"Models"};" +
               $"{GeneralClass.newlinepad(12)}//return (await _unitOfWork.{entityName}Repository" +
               $"{GeneralClass.newlinepad(16)}// .GetMatch(s => s.GuidId == request.Request{entityName}DTO.GuidId, null, cancellationToken))" +
               $"{GeneralClass.newlinepad(16)}//.Map((result => new {entityName}ResponseDTO(result.GuidId, result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, null)));" +
               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceGetByIdQueryHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using Microsoft.Extensions.Logging;\n" +
                   //       $"using {name_space}.Application.CQRS.Model.Queries;\n" +
                   $"using {name_space}.Domain.Errors;\n" +
                $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
               //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
               $"namespace {name_space}.Application.CQRS\n{{" +
               $"{GeneralClass.newlinepad(4)}public sealed class Get{entityName}ByIdQueryHandler  :  IRequestHandler<Get{entityName}ByIdQuery, Either<GeneralFailure, {entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly ILogger<Get{entityName}ByIdQueryHandler> _logger;" +
                $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}ByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<Get{entityName}ByIdQueryHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, {entityName}ResponseDTO>> Handle(Get{entityName}ByIdQuery request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
                              $"{GeneralClass.newlinepad(12)}//List<string> includes = null;// empty list  null;//new List<string>() {"Models"};" +
               $"{GeneralClass.newlinepad(12)}//return (await _unitOfWork.{entityName}Repository" +
               $"{GeneralClass.newlinepad(16)}//.GetMatch(s => s.entityName == request.Request{entityName}DTO.entityName, null, cancellationToken))" +
               $"{GeneralClass.newlinepad(16)}//.Map((result => new {entityName}ResponseDTO(result.GuidId, result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, null)));" +

               $"{GeneralClass.newlinepad(8)}}}");
        }

        public static string ProduceGetByGuidQueryHandlerHeader(string name_space, string entityName, string apiVersion)
        {
            return ($"using {name_space}.Domain.Interfaces;\n" +
                $"using Microsoft.Extensions.Logging;\n" +
                 // $"using {name_space}.Application.CQRS.Model.Queries;\n" +
                 $"using {name_space}.Domain.Errors;\n" +
                 $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
               $"using LanguageExt;\nusing MediatR;\n" +
                //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                $"namespace {name_space}.Application.CQRS\n{{" +
               $"{GeneralClass.newlinepad(4)}public sealed class Get{entityName}ByGuidQueryHandler  :  IRequestHandler<Get{entityName}ByGuidQuery, Either<GeneralFailure, {entityName}ResponseDTO>>" +
               $"{GeneralClass.newlinepad(4)}{{" +

               // constructor
               $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
               $"{GeneralClass.newlinepad(8)}private readonly ILogger<Get{entityName}ByGuidQueryHandler> _logger;" +
                $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
               $"{GeneralClass.newlinepad(8)}public Get{entityName}ByGuidQueryHandler(IUnitOfWork unitOfWork, ILogger<Get{entityName}ByGuidQueryHandler> logger, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
               $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
               $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
               $"{GeneralClass.newlinepad(8)}}}" +
               $"\n" +

               //handler
               $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, {entityName}ResponseDTO>> Handle(Get{entityName}ByGuidQuery request, CancellationToken cancellationToken)" +
               $"{GeneralClass.newlinepad(8)}{{" +
               $"{GeneralClass.newlinepad(12)}throw new NotImplementedException();" +
               $"{GeneralClass.newlinepad(12)}//List<string> includes = null;// empty list  null;//new List<string>() {"Models"};" +
               $"{GeneralClass.newlinepad(12)}//return (await _unitOfWork.{entityName}Repository" +
               $"{GeneralClass.newlinepad(16)}//.GetMatch(s => s.GuidId == request.Request{entityName}DTO.GuidId, null, cancellationToken))" +
               $"{GeneralClass.newlinepad(16)}//.Map((result => new {entityName}ResponseDTO(result.GuidId, result.ProcessFlowGroupName, result.DefaultTestingMode, result.Description, null)));" +

               $"{GeneralClass.newlinepad(8)}}}");
        }


        public static string ProduceUpdateCommandhandler(string name_space, string entityName, string apiVersion)
        {

            return ($"using {name_space}.Domain.Interfaces;\n" +
                         $"using Microsoft.Extensions.Logging;\n" +
                          // $"using {name_space}.Application.CQRS.Model.Commands;\n" +
                          $"using LanguageExt;\nusing MediatR;\nusing MediatR;\nusing AutoMapper;" +
                          $"using {name_space}.Domain.Errors;\n" +
                          $"using {name_space}.Contracts.ResponseDTO.V{apiVersion};\n" +
                          //$"namespace {name_space}.Application.CQRS.{entityName}.Handlers\n{{" +
                          $"namespace {name_space}.Application.CQRS\n{{" +
                          $"{GeneralClass.newlinepad(4)}public sealed class Update{entityName}CommandHandler  :  IRequestHandler<Update{entityName}Command, Either<GeneralFailure, int>>" +
                          $"{GeneralClass.newlinepad(4)}{{" +

                          // constructor
                          $"{GeneralClass.newlinepad(8)}private readonly IUnitOfWork _unitOfWork;" +
                          $"{GeneralClass.newlinepad(8)}private readonly ILogger<Update{entityName}CommandHandler> _logger;" +
                           $"{GeneralClass.newlinepad(8)}public I{entityName}Repository _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository ;" +
                          $"{GeneralClass.newlinepad(8)}private readonly IMapper _mapper;" +
                          $"{GeneralClass.newlinepad(8)}public Update{entityName}CommandHandler(IUnitOfWork unitOfWork, ILogger<Update{entityName}CommandHandler> logger, IMapper mapper, I{entityName}Repository {GeneralClass.FirstCharSubstringToLower(entityName)}Repository )" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}_unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));" +
                          $"{GeneralClass.newlinepad(12)}_logger = logger ?? throw new ArgumentNullException(nameof(logger));" +
                          $"{GeneralClass.newlinepad(12)}_mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));" +
                          $"{GeneralClass.newlinepad(12)}_{GeneralClass.FirstCharSubstringToLower(entityName)}Repository = {GeneralClass.FirstCharSubstringToLower(entityName)}Repository  ?? throw new ArgumentNullException(nameof({GeneralClass.FirstCharSubstringToLower(entityName)}Repository ));" +
                          $"{GeneralClass.newlinepad(8)}}}" +
                          $"\n" +

                          //handler
                          $"{GeneralClass.newlinepad(8)}public async Task<Either<GeneralFailure, int>> Handle(Update{entityName}Command request, CancellationToken cancellationToken)" +
                          $"{GeneralClass.newlinepad(8)}{{" +
                          $"{GeneralClass.newlinepad(12)}throw new NotImplementedException(\"OPERATION NOT ALLOWED\");" +
                          $"{GeneralClass.newlinepad(12)}var entity = _mapper.Map<Domain.Entities.{entityName}>(request.Update{entityName}DTO);" +
                          $"{GeneralClass.newlinepad(12)}return await _{GeneralClass.FirstCharSubstringToLower(entityName)}Repository.UpdateAsync(entity, cancellationToken);" +
                          $"{GeneralClass.newlinepad(8)}}}");

        }
    }
}