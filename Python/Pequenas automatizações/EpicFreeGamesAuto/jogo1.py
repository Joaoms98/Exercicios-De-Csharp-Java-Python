import pyautogui
import pyperclip
import time

#abertura do app
pyautogui.press("win")
time.sleep(1)
pyautogui.write("epic")

time.sleep(2)

pyautogui.press("enter")

time.sleep(30)

#rolagem da tela e click no jogo1
pyautogui.scroll(-1250)
pyautogui.click(x=427, y=621)

time.sleep(5)

#finalização da compra
pyautogui.click(x=1043, y=607)
time.sleep(10)
pyautogui.click(x=1070, y=672)


#rolagem da tela e click no jogo2
time.sleep(10)

pyautogui.click(x=228, y=223) #clique no store

time.sleep(5)

pyautogui.click(x=794, y=459)

time.sleep(5)

#finalização da compra
pyautogui.click(x=1070, y=672)
time.sleep(5)
pyautogui.click(x=1070, y=672)