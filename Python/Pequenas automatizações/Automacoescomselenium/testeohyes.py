from selenium import webdriver
from selenium.webdriver.common.keys import Keys
from datetime import datetime

navegador = webdriver.Edge()
navegador.get("https://www.google.com.br/")

navegador.find_element('xpath','/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input').send_keys("cotacao dolar")


_time = datetime.now()
print(_time)