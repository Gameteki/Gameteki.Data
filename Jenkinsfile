node {
    stage('Checkout git repo') {
        checkout scm
    }

    stage('build') {
        sh(script: "dotnet restore", returnStdout: true)
        sh(script: "dotnet build -c Release", returnStdout: true)
    }

    stage('package') {
        sh(script: "dotnet pack -c Release /p:Version=1.0.0.${BUILD_NUMBER} --include-symbols -p:SymbolPackageFormat=snupkg", returnStdout: true)
    }

    stage('SonarQube analysis) {
        def sqScannerMsBuildHome = tool 'sonar-msbuild'
        withSonarQubeEnv('Local Sonar') {
          // Due to SONARMSBRU-307 value of sonar.host.url and credentials should be passed on command line
          bat "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe begin /k:Gameteki.Data /n:Gameteki.Data /v:1.0 /d:sonar.host.url=%SONAR_HOST_URL% /d:sonar.login=%SONAR_AUTH_TOKEN%"
          bat 'MSBuild.exe /t:Rebuild'
          bat "${sqScannerMsBuildHome}\\SonarQube.Scanner.MSBuild.exe end"
        }
    }

    stage('deploy') {
        withCredentials([string(credentialsId: 'nuget_apikey', variable: 'NUGET_APIKEY')]) {
            sh(script: "dotnet nuget push bin/Release/CrimsonDev.Gameteki.Data.1.0.0.${BUILD_NUMBER}.nupkg -k ${NUGET_APIKEY} -s https://api.nuget.org/v3/index.json")
        }
    }
}