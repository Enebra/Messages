set VS2013="C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\bin\vcvars32.bat"
set VS2013_AMD64="C:\Program Files (x86)\Microsoft Visual Studio 12.0\VC\bin\amd64\vcvars64.bat"


set file=biometric_service/services/database_service.proto


CALL %VS2013%

cd  C:\Users\Yaroslav\Documents\Software projects\Bioskynet\Messages

protoc --grpc_out=.\cpp --plugin=protoc-gen-grpc=grpc_cpp_plugin.exe %file% --proto_path biometric_service
protoc --cpp_out=.\cpp %file% --proto_path biometric_service

call protoc --grpc_out=.\csharp --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe %file% --proto_path biometric_service
call protoc --csharp_out=.\csharp %file% --proto_path biometric_service

pause

:://---------------------------------------------------------------------

::db service

:: cpp
protoc --grpc_out=.\cpp --plugin=protoc-gen-grpc=grpc_cpp_plugin.exe %file% --proto_path biometric_service
protoc --cpp_out=.\cpp %file% --proto_path biometric_service

:: csharp
protoc --grpc_out=.\csharp --plugin=protoc-gen-grpc=grpc_csharp_plugin.exe %file% --proto_path biometric_service
protoc --csharp_out=.\csharp %file% --proto_path biometric_service

:: go
protoc --go_out=plugins=grpc:golang %file% --proto_path biometric_service