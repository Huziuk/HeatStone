/** @type {import('tailwindcss').Config} */
module.exports = {
  mode: 'jit',
  content: [
    './**/*.razor',
    './**/*.razor.css',
    './**/*.html'
  ],
  theme: {
    screens: {
      sm: "420px",
      md: "768px",
      md2: "900px",
      lg: "1024px",
      xl: "1280px",
      full: "1440px"
    },
    container: {
      center: true,
      padding: 0
    },
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
        hoverDark: "#252525",
        secondGray: "#A0A0A0",
        hoverRed: "#C90000",
        hoverYellow: "#F0DC2F",
        secondWhite: "#EEF1F4",
        whiteDark: "#8B8B8B",
        whiteGray: "#EEEEEE",
        borderColor: "#B9B9B9"
      }
    },
  },
  plugins: [],
}

