package main

import (
	"fmt"
	"log"
	"os"
	"os/exec"
)

func main() {
	Init()
}

func Init() {
	fmt.Println("\033[35m")
	fmt.Println(Banner())
	fmt.Println("\n")
	var userInput int = 1

	for userInput != 0 {
		ShowOption()
		_, err := fmt.Scanln(&userInput)
		if err != nil {
			return
		}
		UserInput(userInput)
	}
}

func Banner() string {
	content, err := os.ReadFile("banner.txt")
	if err != nil {
		log.Fatal(err)
	}
	return string(content)
}

func ShowOption() {
	fmt.Println("1 -> build client")
	fmt.Println("2 -> run server")
	fmt.Println("0 -> Close CLI")
}

func UserInput(value int) {
	switch value {
	case 1:
		BuildClient()
		break
	case 2:
		BuildServer()
		break
	}
}

func BuildClient() {
	fmt.Println("build client")
}

func BuildServer() {
	changeDirectory("../Server/")
	cmd := exec.Command("pwd")
	err := cmd.Run()
	if err != nil {
		log.Panic(err)
	}
}

func changeDirectory(directory string) {
	cmd := exec.Command("cd", "../Server/")
	err := cmd.Run()
	if err != nil {
		log.Panic(err)
	}
}

func RunServer() {
	fmt.Println("run server")
}
