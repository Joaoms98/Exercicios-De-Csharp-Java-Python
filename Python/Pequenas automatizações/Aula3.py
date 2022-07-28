#pip install selenium  for install selenium 
#download the webdriver  googlechrone chronedriver / firefox geckdriver

from selenium import webdriver
from selenium.webdriver.common.keys import Keys


#open navigator, before . insert navegator name
navegador = webdriver.Chrome()


#Search url site
navegador.get("link with htpps")



#parameters (type search "xpath", xpath code find this code with inspections elements and copy, command from insert new text or next else
navegador.find_element('xpath', '/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input'.send_keys("cotacao dolar")


#enter for consult 
navegador.find_element('xpath', '/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input'.send_keys(keys.ENTER)


#get atribute
cotacao_dolar = navegador.find_element('xpath', '//*[@id="knowledge-currency__updatable-data-column"]/div[1]/div[2]/span[1]'.get_atribute('data-value')


#replace 
#cotacao_dolar = cotacao_dolar.replace('.',',')


navegador.quit()


#import database

import pandas as pd

tabela = pd.read_excel("Produtos.xlsx")
print(tabela)


#release  database
#loc= localizar   (line, colunn)

#tabela["Moeda"]=="Dólar"   comparation   when colunn "moeda" this equals "dolar"


tabela.loc[["Moeda"]=="Dólar", "Cotação"] = float(cotacao_dolar)