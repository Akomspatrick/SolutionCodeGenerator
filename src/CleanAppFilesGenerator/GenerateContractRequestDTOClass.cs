﻿
using System.Text;

namespace CleanAppFilesGenerator
{
    public class GenerateContractRequestDTOClass
    {
        public static string GenerateRequest(Type type, string name_space)
        {
            var Output = new StringBuilder();
            Output.Append(GenerateRequestHeader(name_space, type));
            Output.Append(GeneralClass.newlinepad(0) + GeneralClass.ProduceClosingBrace());
            return Output.ToString();
        }

        //private static string GenerateRequestHeader(string name_space, Type type)
        //{
        //    return ($"namespace {name_space}.Contracts.RequestDTO\n{{" +

        //         $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestByGuidDTO(Guid guid);" +
        //         $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestByIdDTO(Object Value);" +
        //         $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestDTO(Object Value);" +

        //        $"{GeneralClass.newlinepad(4)}public  record {type.Name}CreateRequestDTO(Guid GuidId,Object Value );" +
        //        $"{GeneralClass.newlinepad(4)}public  record {type.Name}UpdateRequestDTO(Object Value);" +

        //        $"{GeneralClass.newlinepad(4)}public  record {type.Name}DeleteRequestDTO(Guid guid);" +
        //        $"");

        //}
        private static string GenerateRequestHeader(string name_space, Type type)
        {
            return ($"namespace {name_space}.Contracts.RequestDTO\n{{" +

                 $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestByGuidDTO(Guid guid);" +
                 $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestByIdDTO(String ObjectNameId);" +
                 $"{GeneralClass.newlinepad(4)}public  record {type.Name}GetRequestDTO(Object Value);" +

                $"{GeneralClass.newlinepad(4)}public  record {type.Name}CreateRequestDTO({GeneralClass.ProduceEntitySignatureFunction(type)} );" +
                $"{GeneralClass.newlinepad(4)}public  record {type.Name}UpdateRequestDTO({GeneralClass.ProduceEntitySignatureFunction(type)});" +

                $"{GeneralClass.newlinepad(4)}public  record {type.Name}DeleteRequestDTO(Guid guid);" +
                $"");

        }

    }
}
