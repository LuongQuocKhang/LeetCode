package string_easy

import (
	"fmt"
	"strings"
)

/***
* Tag: Easy
* Name: 1684. Count the Number of Consistent Strings
* Start Time: 04/08/2024 15:30 PM
* End Time: 04/08/2024 15:34 PM
* Time Complexity: O(N*M)
* Result:
	* Runtime: solution 1: Beats 62.64% of users with Go ( 29ms )
	* Memory:  solution 1: Beats 37.07% of users with Go ( 7.13MB )
***/

func RunCountConsistentStrings() {
	var allowed string = "ab"
	var words = []string{"ad", "bd", "aaab", "baa", "badab"}

	fmt.Println(countConsistentStrings(allowed, words))
}

func countConsistentStrings(allowed string, words []string) int {

	var count int = 0

	for _, v := range words { // O(N)

		var isContained = true // O(1)

		for _, c := range v { // O(M)
			if !strings.Contains(allowed, string(c)) { // O(M)
				isContained = false // // O(1)
				break
			}
		}

		if isContained { // O(N)
			count = count + 1 // O(1)
		}

	}
	// => 0(N*M)
	return count
}
