FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY . .


# catalog of supported runtimes https://learn.microsoft.com/en-us/dotnet/core/rid-catalog
RUN dotnet restore && \
    dotnet publish -c release --self-contained --runtime linux-x64 --framework net6.0 -o /app/fhirconvert

CMD ["/app/fhirconvert/Microsoft.Health.Fhir.Liquid.Converter.Tool", "--help"]
