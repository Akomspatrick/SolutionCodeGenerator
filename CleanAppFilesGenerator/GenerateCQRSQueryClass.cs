﻿
using System.Text;
using System.Xml.Linq;

namespace CleanAppFilesGenerator
{
    public class GenerateCQRSQueryClass
    {
        public static string GenerateGetAllQuery(Type type, string thenamespace)
        {
           return "NOT YET";
        }

        public static string GenerateGetQuey(Type type, string thenamespace)
        {
           return "NOT YET";
        }

        public static string GenerateCQRSQuey(Type type, string name_space, Func<string, string, string> produceheader)
        {
            var Output = new StringBuilder();
            Output.Append(produceheader(name_space, type.Name));
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }

        public static string ProduceGetQueryHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Application.Contracts.RequestDTO;\n" +
                $"\"using {name_space}.Application.Contracts.ResponsetDTO;\n" +
                $"using  {name_space}.Domain.Errors;\n" +
               $"using {name_space}.Domain.Errors;\nusing LanguageExt;\nusing MediatR;\n" +
               $"namespace {name_space}.Application.CQRS.{entityName}.Queries\n{{{GeneralClass.newlinepad(4)}public  record Get{entityName}Query(ApplicationRequest{entityName}DTO : Request{entityName}DTO) :  IRequest<Either<GeneralFailures, ApplicationRequest{entityName}DTO>>;");

        }
        public static string ProduceGetAllQueryHeader(string name_space, string entityName)
        {
            return ($"using {name_space}.Application.Contracts.RequestDTO;\n" +
              $"\"using {name_space}.Application.Contracts.ResponsetDTO;\n" +
              $"using  {name_space}.Domain.Errors;\n" +
             $"using {name_space}.Domain.Errors;\nusing LanguageExt;\nusing MediatR;\n" +
             $"namespace {name_space}.Application.CQRS.{entityName}.Queries\n{{{GeneralClass.newlinepad(4)}public  record GetAll{entityName}Query(ApplicationRequest{entityName}DTO : Request{entityName}DTO) :  IRequest<Either<GeneralFailures, IEnumerable<ApplicationRequest{entityName}DTO>>>;");


        }
    }
}