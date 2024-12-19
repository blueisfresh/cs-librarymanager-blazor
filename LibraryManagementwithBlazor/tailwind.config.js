/** @type {import('tailwindcss').Config} */
module.exports = {
    mode: 'jit',
    content: [
        './**/*.razor', // Include Razor files
        './wwwroot/**/*.html', // Include HTML files
    ],
    theme: {
        extend: {}, // Extend default theme here
    },
    plugins: [],
};





