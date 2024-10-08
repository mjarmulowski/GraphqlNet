export default function Logo({ className = undefined, ...props }) {
  return (
    <div className={className || 'font-bold text-white py-2 subpixel-antialiased flex items-center'} {...props}>
      {/* SVG symbolu </> */}
      <svg className="inline h-6 w-6 mr-1" width={30} height={30} fill="none" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 24 24" stroke="currentColor">
        <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M10 20l4-16m4 4l4 4-4 4M6 16l-4-4 4-4" />
      </svg>
      <span className="hidden md:inline">
        Books Review
      </span>
    </div>
  );
}
