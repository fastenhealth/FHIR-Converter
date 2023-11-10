FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY . .

RUN dotnet restore && \
    dotnet publish -c release --self-contained --runtime linux-x64 --framework net6.0 -o /app/fhirconvert
