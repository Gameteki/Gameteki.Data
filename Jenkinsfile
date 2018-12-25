node {
    stage('Checkout git repo') {
        checkout scm
    }

    stage('Build and Sonar Qube') {
        sh(script: "dotnet restore", returnStdout: true)
        withSonarQubeEnv('Local Sonar') {
            sh(script: "dotnet sonarscanner begin /k:Gameteki.Data /d:sonar.host.url=${SONAR_HOST_URL} /d:sonar.login=${SONAR_AUTH_TOKEN}", returnStdout: true)
            sh(script: "dotnet build -c Release", returnStdout: true)
            sh(script: "dotnet sonarscanner end /d:sonar.login=${SONAR_AUTH_TOKEN}", returnStdout: true)
        }
    }

    stage('package') {
        sh(script: "dotnet pack -c Release /p:Version=1.0.0.${BUILD_NUMBER} --include-symbols -p:SymbolPackageFormat=snupkg", returnStdout: true)
    }

    stage('deploy') {
        withCredentials([string(credentialsId: 'nuget_apikey', variable: 'NUGET_APIKEY')]) {
            sh(script: "dotnet nuget push bin/Release/CrimsonDev.Gameteki.Data.1.0.0.${BUILD_NUMBER}.nupkg -k ${NUGET_APIKEY} -s https://api.nuget.org/v3/index.json")
        }
    }
}