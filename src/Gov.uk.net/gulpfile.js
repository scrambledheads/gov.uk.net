/// <binding />
const gulp = require('gulp');
var sass = require('gulp-dart-sass');

gulp.task('sass', () => {
    return gulp.src('./lib/govuk/*.scss')
        .pipe(sass({ outputStyle: 'compressed' }).on('error', sass.logError))
        .pipe(gulp.dest('./wwwroot/assets/styles'));
});

/*
 * Move files
 */
gulp.task('fonts:copy', () => {
    return gulp.src('./lib/govuk/assets/fonts/*')
        .pipe(gulp.dest('./wwwroot/assets/fonts'));
});

gulp.task('images:copy', () => {
    return gulp.src('./lib/govuk/assets/images/*')
        .pipe(gulp.dest('./wwwroot/assets/images'));
});

gulp.task('js:copy', () => {
    return gulp.src('./lib/govuk/all.js')
        .pipe(gulp.dest('./wwwroot/assets/js/'));
});

/*
 * Build
 */
gulp.task('build', gulp.series('sass','fonts:copy', 'images:copy', 'js:copy'));