FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
COPY . .

RUN dotnet restore && \
    dotnet publish -c release --self-contained --runtime linux-x64 --framework netcoreapp2.0 -o /app/fhirconvert
