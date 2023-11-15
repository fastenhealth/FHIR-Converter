#FROM --platform=linux/amd64 ghcr.io/oras-project/oras:v1.1.0 as oras
#RUN oras pull healthplatformregistry.azurecr.io/hl7v2defaulttemplates:v5.1 -o hl7v2defaulttemplates && \
#    mkdir -p /templates && \
#    tar -xvf hl7v2defaulttemplates/layer1.tar.gz -C /templates

FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
COPY . .

# catalog of supported runtimes https://learn.microsoft.com/en-us/dotnet/core/rid-catalog
RUN dotnet restore && \
    dotnet publish -c release --self-contained --runtime linux-x64 --framework net6.0 -o /app/fhirconvert

FROM --platform=linux/amd64 ubuntu
WORKDIR /app
COPY /data/Templates /app/templates
COPY --from=build /app/fhirconvert /app/fhirconvert

CMD ["/app/fhirconvert/Microsoft.Health.Fhir.Liquid.Converter.Tool"]
