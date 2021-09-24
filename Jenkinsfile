pipeline {
    agent any
    environment {
       dotnet = '"C:\\Program Files\\dotnet\\dotnet.exe"'
    }


    stages {
        stage('Build') {
            steps {
                 bat "${dotnet} build"
            }
        }
        stage('Test') {
            steps {
                dir("test"){
                    bat "${dotnet} test"
                   }

            }
        }
        stage('Clean') {
            steps {
                bat "${dotnet} clean"
                dir("test"){
                    bat "${dotnet} clean"
                   }
            }
        }
    }
}