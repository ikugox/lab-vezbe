package main

import (
	"fmt"
	"math"
	"os"
)

func main() {
	if len(os.Args) < 4 {
		fmt.Println("Usage: go run main.go <file name> <pattern> <input alphabet>")
		return
	}
	fileName := os.Args[1]
	pattern := os.Args[2]

	var inputAlphabet int
	_, err := fmt.Sscanf(os.Args[3], "%d", &inputAlphabet)
	if err != nil {
		fmt.Println("Error reading input:", err)
		return
	}

	// // postoji i ova implementacija ako iz nekog razloga ne mozete terminal argumente da ukucate
	// // ...jer ne znam kako golang izgleda na windows
	//
	// var fileName, pattern string
	// fmt.Println("Insert the file directory, followed by the pattern you want to find:")
	// _, err := fmt.Scanln(&fileName, &pattern)
	// if err != nil {
	// 	fmt.Println("Error reading input:", err)
	// 	return
	// }

	text, err := os.ReadFile(fileName)
	if err != nil {
		fmt.Println("Error reading file:", err)
		return
	}
	rabinSearch(pattern, string(text), inputAlphabet, 101)
}

func rabinSearch(pattern, text string, d, q int) {
	m := len(pattern)
	n := len(text)
	p, t := 0, 0
	h := int(math.Pow(float64(d), float64(m-1))) % q

	for i := 0; i < m; i++ {
		p = (d*p + int(pattern[i])) % q
		t = (d*t + int(text[i])) % q
	}

	for i := 0; i <= n-m; i++ {
		// fmt.Printf("%s, %s\n", text[i:i+m], pattern)

		if p == t {
			bruteForceSearch(pattern, text, i)
		}

		if i < n-m {
			t = (d*(t-int(text[i])*h) + int(text[i+m])) % q
			if t < 0 {
				t += q
			}
		}
	}
}

func bruteForceSearch(pattern, text string, i int) {
	m := len(pattern)
	for j := 0; j < m; j++ {
		if text[i+j] != pattern[j] {
			// fmt.Printf("%s != %s\n", text[i:i+m], pattern)
			return
		}
	}
	fmt.Printf("%d ", i)
	// fmt.Printf("Pattern found!!! => %s == %s\n", text[i:i+m], pattern)
}
