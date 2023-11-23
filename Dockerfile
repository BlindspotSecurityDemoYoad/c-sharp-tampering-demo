FROM mcr.microsoft.com/dotnet/sdk:8.0
WORKDIR /app
RUN git clone https://github.com/BlindspotSecurityDemoYoad/c-sharp-mvc-demo .
CMD ["dotnet", "run", "--urls", "http://0.0.0.0:8000"]
