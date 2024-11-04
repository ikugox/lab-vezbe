package main

import (
	"fmt"
	"math/rand"
	"os"
)

func main() {
	digits := [4]int{100, 1000, 10000, 100000}

	for i, size := range digits {
		text := generateText(size)
		fileName := "text" + fmt.Sprintf("%d", i+1) + ".txt"
		writeToFile(fileName, text)
	}
}

func generateText(size int) []byte {
	text := make([]byte, size)
	for i := 0; i < size; i++ {
		num := rand.Intn(16)
		if num < 10 {
			text[i] = '0' + byte(num)
		} else {
			text[i] = 'a' + byte(num-10)
		}
	}
	return text
}

func writeToFile(fileName string, text []byte) {
	err := os.WriteFile(fileName, text, 0666)
	if err != nil {
		fmt.Println("Error writing to file:", err)
		return
	}
	fmt.Printf("Generated text to file %s\n", fileName)
}
