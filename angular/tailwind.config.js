module.exports = {
  corePlugins: {
    preflight: false,
 },
  prefix: 'tw-',
  theme: {
    screens: {
      'sm': '576px',
      'md': '768px',
      'lg': '992px',
      'xl': '1200px',
    }
  },
  content: [
    "./src/**/*.{html,ts}",
  ],
  plugins: [],
}