import pyautogui
import pyperclip
import time

#abertura do app
pyautogui.press("win")
time.sleep(1)
pyautogui.write("epic")

time.sleep(2)


pyautogui.press("enter")

#rolagem da tela e click no jogo
time.sleep(30)

pyautogui.scroll(-1250)
pyautogui.click(x=427, y=621)

time.sleep(5)

#finalização da compra
pyautogui.click(x=1041, y=625)