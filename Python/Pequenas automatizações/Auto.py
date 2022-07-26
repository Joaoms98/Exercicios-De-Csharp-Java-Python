import pyautogui
import pyperclip
import time


pyautogui.press("win")
pyautogui.write("opera")
time.sleep(1)
pyautogui.press("enter")

time.sleep(5)

pyautogui.hotkey("ctrl","shift","n")
time.sleep(1)
pyperclip.copy("www.gmail.com")
pyautogui.hotkey("ctrl","v")
pyautogui.press("enter")

