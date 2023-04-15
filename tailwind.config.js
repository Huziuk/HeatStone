/** @type {import('tailwindcss').Config} */
module.exports = {
  mode: 'jit',
  content: [
    './**/*.razor',
    './**/*.razor.css',
    './**/*.html'
  ],
  theme: {
    fontFamily: {
      firsNeue: "TT Firs Neue",
      mulish: "Mulish"
    },
    extend: {
      colors: {
        dark: "#161616",
        gray: "#C5C5C5",
        red: "#E4002B",
        blue: "#0085FF",
        yellow: "#FBE739",
        pink: "#FCE6EA",
        secondDark: "#252525",
        secondGray: "#A0A0A0",
        secondRed: "#C90000",
        secondYellow: "#F0DC2F",
        secondWhite: "#EEF1F4",
        whiteDark: "#8B8B8B",
        whiteGray: "#EEEEEE",
        
      }
    },
  },
  plugins: [],
}

