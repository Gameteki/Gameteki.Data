node {
    stage('Checkout git repo') {
        checkout scm
    }

    stage('build') {
        sh(script: "dotnet pack -c Release /p:Version=1.0.0.${BUILD_NUMBER} --include-symbols -p:SymbolPackageFormat=snupkg", returnStdout: true)
    }

    stage('deploy') {
        withCredentials([string(credentialsId: 'nuget_apikey', variable: 'NUGET_APIKEY')]) {
            sh(script: "dotnet nuget push -k ${NUGET_APIKEY} -s https://api.nuget.org/v3/index.json")
        }
    }
}