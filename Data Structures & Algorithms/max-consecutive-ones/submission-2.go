func findMaxConsecutiveOnes(nums []int) int {
	n := len(nums)
	max, count := 0, 0

	for i := 0; i < n; i++ {
		if nums[i] == 1 {
			count += 1
		} else {
			count = 0
		}
		if count > max {
			max = count
		}
	}

	return max
}
