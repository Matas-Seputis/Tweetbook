FROM Microsoft/dotnet:5-sdk as build

ARG BUILDCONFIG=RELEASE
ARG VERSION=1.0.0

COPY Tweetbook.csproj /build/

RUN dotnet restore ./build/Tweetbook.scproj

COPY . ./build/
WORKDIR /build/
RUN dotnet publish ./Tweetbook.csproj -c $BUILDCONFIG -o /p:Version=$VERSION

FROM microsoft/dotnet:5-aspnetcore-runtime
WORKDIR /app

COPY --from=build /build/out .

ENTRYPOINT ["dotnet", "Tweetbook.dll"]