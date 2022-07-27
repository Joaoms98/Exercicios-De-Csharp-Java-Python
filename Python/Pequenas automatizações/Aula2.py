from locale import normalize
import pandas as pd
import plotly.express as px

tabela = pd.read_csv(r"C:\Users\jvm18\Desktop\prograhmaisaoção\Exercicios-De-Csharp-Java-Python\Python\telecom_users.csv")

#tabela = tabela.drop("nome",eixo)
#axis= 0 excluir linha e colocar o nome
#axis= 1 excluir coluna e colocar o nome
tabela = tabela.drop("Unnamed: 0", axis=1)

#transforma todos os dados em numero
#coerce= forçar ficar vazio, poderia colocar valor 0
tabela ["TotalGasto"] = pd.to_numeric(tabela["TotalGasto"], errors="coerce")


#precisa do parametro how e axis
tabela = tabela.dropna(how="all",axis=1)
tabela = tabela.dropna(how="any",axis=0)


#para trazer informações
##print(tabela.info())
##print(tabela)

print(tabela["Churn"].value_counts())
print(tabela["Churn"].value_counts(normalize=True).map("{:.1%}".format))

#for coluna in tabela.columns:
    #criar gráfico
    #parametro o nome da tabela, os valores para o eixo x, colores do gráfico
grafico = px.histogram(tabela, x="Aposentado", color="Churn", text_auto=True)
grafico.show()