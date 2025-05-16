Write-Host "🔄 Limpando solução..."
dotnet clean

Write-Host "🧪 Executando testes com cobertura..."
dotnet test --collect:"XPlat Code Coverage" --results-directory TestResults

Write-Host "Gerando relatório consolidado..."
reportgenerator `
  -reports:"TestResults/**/*.cobertura.xml" `
  -targetdir:"TestResults/Report" `
  -reporttypes:Html

# Verifica se o arquivo existe antes de abrir
if (Test-Path "TestResults/Report/index.html") {
    Start-Process "TestResults/Report/index.html"
} else {
    Write-Host "Arquivo de relatório não encontrado para abrir."
}
