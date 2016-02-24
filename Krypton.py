from tkinter import *

krypton = Tk()

topFrame = Frame(krypton)
topFrame.pack(side = TOP)
bottomFrame = Frame(krypton)
bottomFrame.pack(side = BOTTOM)

button1 = Button(topFrame, text="test1", fg = "red")
button2 = Button(topFrame, text="test2", fg = "blue")
button3 = Button(topFrame, text="test3", fg = "yellow")
button4 = Button(bottomFrame, text="test4", fg = "green")

button1.pack(side = LEFT)
button2.pack(side = LEFT)
button3.pack(side = LEFT)
button4.pack(side = BOTTOM)

krypton.mainloop()
